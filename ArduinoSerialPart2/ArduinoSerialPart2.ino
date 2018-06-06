/*
*
* Sketch Arduino to Visual Basic 002
*
* Read pin state / value and send to a host computer over a serial connection.
* This is a one way communication; Arduino to a host computer. No data is received from the computer.
*
* Pins
* A0 - a 2 wire temperature probe (sending raw data only. Not the actual temperature)
* A1 - a potentiometer
* D4 - button switch
* The above can be changed to something else
*
* Only send a value if the value has changed.
* This means we need to store the old value
*
*
* It should noted that no data is sent until something changes
* The sketch can be expanded so that an initial value is sent
*
*/

// When DEGUG is TRUE send an newline to the serial monitor
const boolean DEBUG = true;
 
const byte tempPin = A0;
const byte potPin = A1;
const byte buttonSwitchPin = 4;

unsigned int oldTempVal = 0;
unsigned int newTempVal = 0;
unsigned int oldPotVal = 0;
unsigned int newPotVal = 0;
boolean oldButtonSwitchState = false;
boolean newButtonSwitchState = false;

// used to hold an ascii representation of a number
// [10] allows for 9 digits but in this example I am only using 4 digits
char numberString[10];



void setup()  
{
  // set the button switch pin to input
  pinMode(buttonSwitchPin, INPUT); 
  
  // open serial communication
  Serial.begin(9600);
  Serial.println("Adruino is ready");
  Serial.println(" ");
}




void loop()  
{
    
    // read the pins
    newTempVal = analogRead(tempPin); 
    newPotVal = analogRead(potPin); 
    newButtonSwitchState = digitalRead(buttonSwitchPin);

    if (newTempVal != oldTempVal)
    {
       oldTempVal = newTempVal;
       formatNumber( newTempVal, 4);
       Serial.print("<T");
       Serial.print(numberString);
       Serial.print(">");
       if (DEBUG) { Serial.println("");  }
    }
    
    
    //The pot I am using jitters +/-1 so I only using changes of 2 or more.  
    if ( abs(newPotVal-oldPotVal) > 1)
    {
       oldPotVal = newPotVal;
       formatNumber( newPotVal, 4);
       Serial.print("<P");
       Serial.print(numberString);
       Serial.print(">");
       if (DEBUG) { Serial.println("");  }      
    }    
    
    
    if (newButtonSwitchState != oldButtonSwitchState)
    {
       oldButtonSwitchState = newButtonSwitchState;
       if (oldButtonSwitchState == true)
       {
          Serial.print("<BH>");
       }
       else
       {
          Serial.print("<BL>");
       }
       
       if (DEBUG) { Serial.println("");  }
      
    }   
 
    delay (100);

}




void formatNumber( unsigned int number, byte digits)
{
    // formats a number in to a string and copies it to the global char array numberString
    // pads the start of the string with '0' characters
    //
    // number = the integer to convert to a string
    // digits = the number of digits to use. 
    
    char tempString[10] = "\0"; 
    strcpy(numberString, tempString);
    
    // convert an integer into a acsii string
    itoa (number, tempString, 10);
    
    // create a string of '0' characters to pad the number    
    byte numZeros = digits - strlen(tempString) ;
    if (numZeros > 0)
    {
       for (int i=1; i <= numZeros; i++)    { strcat(numberString,"0");  }
    }
    
    strcat(numberString,tempString); 

}




















