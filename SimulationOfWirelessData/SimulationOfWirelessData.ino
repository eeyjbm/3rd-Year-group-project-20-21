const float pi=3.14;

void setup()
{
  Serial.begin(9600);
}
void loop()
{
   static int x = 0;

   if(x>360)
    x = 0;
    
    Serial.print("#");
    Serial.print(35*sin((x*pi/180)+1)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((3*x*pi/180)+2)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((x*pi/180)+0.5)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((x*pi/180))+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((2*x*pi/180))+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((x*pi/180)+0.7)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((x*pi/180)+1.3)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((2*x*pi/180)+0.2)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((x*pi/180)+3)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((2*x*pi/180)+2)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((x*pi/180)+0.5)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((x*pi/180))+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((x*pi/180)+1.2)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((3*x*pi/180)+3.1)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((x*pi/180)+0.7)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((2*x*pi/180)+2.1)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((x*pi/180)+1.5)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((3*x*pi/180)+1)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((x*pi/180)+3.2)+random(-15,15)+50);
    Serial.print(",");
    Serial.print(35*sin((2*x*pi/180)+1.7)+random(-15,15)+50);
    Serial.println();
    x = x + 40;
    delay(750);

}
