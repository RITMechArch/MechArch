void setup(){
    Serial.begin(9600);

    pinMode(34, OUTPUT);
    pinMode(36, OUTPUT);
    pinMode(38, OUTPUT);
}

void loop(){
    unsigned long startMillis, endMillis;

    startMillis = millis();

    double d;
    for (d = 1.0; sqrt(d) < 16.1; d = d + 1)
    {
     digitalWrite(34, LOW);
     digitalWrite(36, LOW);
     digitalWrite(38, LOW);
    }

    endMillis = millis();

    Serial.println(endMillis - startMillis, DEC);

}
