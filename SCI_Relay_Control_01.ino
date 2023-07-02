/*  Author: Johanna Shaw
    Created: July 1, 2023
    Description: Takes input from SCI and uses it to turn on the specified relay 
*/

// the array that will hold all of the pin objects
byte pinOut[8];
// array holding count for relays
unsigned long relays[8];
// the baud rate of the SCI port
unsigned int BAUD = 9600;

// the relay input prefix,
char relayprefix[] = "R";


void setup() {
  // put your setup code here, to run once:

  // initialize the pins, set to low, store in the pinOut array
  for (int i = 0; i < 8; i++)
  {
    // store the board pin number into array at the spot corresponding to it's connected relay (if numbering from 0)
    pinOut[i] = i + 4;

    // set the pin as an output
    pinMode(pinOut[i], OUTPUT);

    // set pin to low
    digitalWrite(pinOut[i], HIGH);
  }

  // initialize the serial port with established BAUD
  Serial.begin(BAUD);


}


void loop() {
  // put your main code here, to run repeatedly:



}


// goes through the relays array and checks if any of the relays need to be turned off
void RelayCheck()
{

  // 
}

int index = 0, lastend = 0;

// this is called at the end of every SCI input event 
void serialEvent() {
  
  static char input[20];
  char char_in;
  // save the received input
  char_in = Serial.read();


  Serial.print(char_in);
  Serial.print("\t");

  Serial.print(char_in, DEC);
  Serial.print("\n");

  // if char received is null, nl line feed, or carriage return
  if (char_in == 0 || char_in == 10 || char_in == 13)
  {
    // if we've already delt with received data, exit function
    if (lastend != index)
      return;

    Serial.write("end\n");
    input[lastend] = 0;
    Serial.write(input);
    index = 0;
  }
  // if any other char was received
  else { 
    //add the received char to the input string and return
    input[index] = char_in;   
    lastend = ++index;
    return;
  }
    

  // check input for if adding to relay on time or if relay needs to be turned off
  for (int i = 0; i < 8; i++)
  {
    // check if you need to increment relay time
    if (input[i] == relayprefix + String(i+1) + "+")
      digitalWrite(pinOut[i], LOW);
      
    // check if relay should be turned off
  }

}









