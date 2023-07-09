/*  Author: Johanna Shaw
    Created: July 1, 2023
    Description: Takes input from SCI and uses it to turn on the specified relay 
          FUCK IT! we're going back to doing this without classes because apparently 
          arduinos like slashing kneecaps for the fun of it and won't let me procedurally fill an object array.
*/

#include <EEPROM.h>

// **********************************************************************************************
// Function Declarations   **********************************************************************
// **********************************************************************************************
void Relay(int index, byte pin);
void ResetDefaults();
bool checkString(int index, String input);
void checkCount(int index);
void Print(int index);
void RelayCheck(); 
void serialEvent();
void Read(int index);
void ReadAll();
// void Write(int index);
void StoreDelay(int index);
void StoreName(int index);
void ChangeName(int index, String newName);



// **********************************************************************************************
// Global Variables   ***************************************************************************
// **********************************************************************************************

//things that can be different for each relay
unsigned char OnTime[8];
unsigned long Count[8];
byte Pin[8]; 
char Name[8][16];

int checkrate = 50;

// the baud rate of the SCI port
unsigned int BAUD = 9600;



void setup() {

  // ResetDefaults();
  
    // initialize the pins, set to low, store in the pinOut array
  for (int i = 0; i < 8; i++)
  {
    // Relay(i, i + 4, 35, String("R" + String(i + 1)));
    Read(i);
    Relay(i, i + 4);    
  }
  
  // initialize the serial port with established BAUD
  Serial.begin(BAUD);
}


void loop() {

  delay(checkrate);

  RelayCheck();

}




// **********************************************************************************************
// Function Definitions   ***********************************************************************
// **********************************************************************************************


// Initializes all values pretaining to the given relay 
void Relay(int index, byte pin){
  // Save the pin for each relay
  Pin[index] = pin;
  
  // set the pin as an output
  pinMode(Pin[index], OUTPUT);

  // set pin to low
  digitalWrite(Pin[index], HIGH);
}

// Resets the Relay DelayTime and Names to their default values, stores them to EEPROM
void ResetDefaults(){
  // iterate through the relays
  for (int index = 0; index < 8; index++)
  {
    // reset the delay to default
    OnTime[index] = 35;

    // reset relay name to default
    ChangeName(index, String("R" + String(index + 1)));

    // Store the default values back to storage
    // Write(index);
    StoreDelay(index);
    StoreName(index);
  }
}

void ChangeName(int index, String newName)
{
  int temp = 0;
  while (newName[temp] != 0 && temp != 15)
  {
    Name[index][temp++] = newName[temp];
    // temp;
  }
  Name[index][temp] = 0;
}

void checkCount(int index){
  // if any >0, decrement 
  if ( Count[index] > 0)
    Count[index]--;
  // else set pin back to high (aka turn off relay)
  else
  {
    digitalWrite(Pin[index], HIGH);
      
  }
}

void Print(int index){
  // Serial.print("\n");OnTime
  Serial.print(String(index) + "," + String(OnTime[index]) + ",");
  Serial.println(Name[index]);

}

void PrintAll()
{
  for (int i = 0; i < 8; i++)
  {
    Print(i);
  }
}
// goes through the relays array and checks if any of the relays need to be turned off
void RelayCheck()
{
  // iterate through the relay array 
  for (int i = 0; i < 8; i++)
  {
    checkCount(i);
  }
}


bool checkString(int index, String input)
{

  // Serial.print(String(String(Name[index]) + "+\n"));
  if (input == String(String(Name[index]) + "+"))
  {
    Count[index] += OnTime[index] * 100 / checkrate;
    digitalWrite(Pin[index], LOW);
  }
  else if (input == String(String(Name[index]) + "_off"))
  // check if relay should be turned off
  {
    // reset the respective relay count and set pin to low
    Count[index] = 0;
    digitalWrite(Pin[index], HIGH);
  }

  // this is a check to ensure that the string is a proper length for the next two cases
  else if (input.length() < 4)
    return false;

  // change name of a relay
  else if (input.substring(0, 3) == String("cn" + String(index)))
  {
    //
    // Serial.println(input.substring(3));
    ChangeName(index, input.substring(3));
    StoreName(index);
    Print(index);
  }
  // change the delay time of a relay
  else if (input.substring(0, 3) == String("cd" + String(index)))
  {
    Serial.println(input.substring(3, 6));
    int newdelay = input.substring(3, 6).toInt();

    if (newdelay > 0 || newdelay < 255)

    // I'm just going to make it so that the first 32 numbers are invalid for this
    // since characters 0, 10, and 13 were used to indicate end of input
    {
      OnTime[index] = newdelay;
      StoreDelay(index);
      
      Serial.println(OnTime[index], DEC);
    }
    Print(index);
  }
  else
    return false;
    
  return true;
}



// this is called at the end of every SCI input event
void serialEvent() {
  static int index = 0, lastend = 0; 
  // array storing the received characters
  static char input[20];

  // save the received input
  char char_in = Serial.read();
  
  //Serial.println(String(char_in, DEC));

  // if char received is null, nl line feed, or carriage return
  if (char_in == 0 || char_in == 10 || char_in == 13)
  {
    // if we've already delt with received data, exit function
    if (lastend != index)
      return;
    input[lastend] = 0;
    Serial.println(input);
    index = 0;
  }
  // Device control 1: print all of the relays
  else if (char_in == 17){    
    PrintAll();
    return;
  }
  // Device control 2: reset all the relays to their defaults
  else if (char_in == 18){
    // Serial.println(char_in, DEC);
    ResetDefaults();
    PrintAll();
    return;
  }
  // if any other char was received
  else { 
    //add the received char to the input string and return
    input[index] = char_in;   
    lastend = ++index;
    return;
  }
  
    
  String inp_str = String(input);

  // check for the end cache case (ie stop all relays)
  if (inp_str == "NO.")
  {
    // iterate through Count
    for (int i = 0; i < 8; i++)
    {
      Count[i] = 0;
    }
    return;
  }

  // check input for if adding to relay on time or if relay needs to be turned off
  for (int i = 0; i < 8; i++)
  {
    
    checkString(i, inp_str);
  }
}

// Retreives the delay time and the relay name from EEPROM and saves them as variables.
void Read(int index) {
    // get the address for the index
  // int addr = 0;
  int i;
  int addr = (index + 8) << 4;

  // Write the delay value to EEPROM
  OnTime[index] = (unsigned char)EEPROM.read(addr++);

  // loop through the Name array
  for (i = 0; i < 15; i++)
  {
    // Write the delay value to EEPROM
    Name[index][i] = (char)EEPROM.read(addr++);
    if (Name[index][i] == 0)
      break;
  }
  // make sure the string is null terminated
  Name[index][i] = 0;

}


void Write(int index){

  // Store the delay value
  StoreDelay(index);

  // Store the Name
  StoreName(index);
}

void StoreDelay(int index){
  // get the address for the index
  // int addr = 0;
  int addr = (index + 8) << 4;
  Serial.print("Write addr: " + String(addr) + "\n");

  // Write the delay value to EEPROM
  EEPROM.write(addr++, OnTime[index]);
}

void StoreName(int index){
  // get the address for the index
  // int addr = 0;
  int addr = ((index + 8) << 4) + 1;

  // loop through the Name array
  for (int i = 0; i < 15; i++)
  {
    // Write the delay value to EEPROM
    EEPROM.write(addr++, Name[index][i]);
  }
}
