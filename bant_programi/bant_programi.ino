#include <SPI.h>
#include <MFRC522.h>
#include <Stepper.h>
#include <Servo.h> 


#define SS_PIN 10
#define RST_PIN 9

MFRC522 mfrc522(SS_PIN, RST_PIN);

int en_son = 1;
int ozel_deger=0;

unsigned int buzzer = 8; //buzzer pin 2

//servolar tanımlanıyor
Servo kapi_a;
Servo kapi_b;

//step motor tanımlanıyor
const int cozunurluk = 200;
Stepper bant_motor(cozunurluk, 2, 3, 4, 5);

void setup() {
    Serial.begin(9600); // Initialize serial communications with the PC
    SPI.begin();            // Init SPI bus
    mfrc522.PCD_Init(); // Init MFRC522 card
    pinMode(buzzer, OUTPUT);
    Serial.begin(9600);
  //servo pinleri
  kapi_a.attach(6);
  kapi_b.attach(7);
  //step motor hız
  bant_motor.setSpeed(60);
  kapi_a.write(180);
  kapi_b.write(180);
}

void loop() {
 bant_motor.step(-100);
 digitalWrite(buzzer, HIGH);  
 rf_id();        
  digitalWrite(buzzer, LOW);
            kapi_a.write(180);
            kapi_b.write(180);
              bant_motor.setSpeed(35);
}

void rf_id(){
   if ( ! mfrc522.PICC_IsNewCardPresent()) {
        return;
    }

    if ( ! mfrc522.PICC_ReadCardSerial()) {
        return;
    }

      //kartın UID'sini oku, rfid isimli string'e kaydet
  String rfid = "";
  for (byte i = 0; i < mfrc522.uid.size; i++)
  {
    rfid += mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " ";
    rfid += String(mfrc522.uid.uidByte[i], DEC);
  }

  rfid.trim();
  rfid.toUpperCase();

  ozel_deger=rfid.toInt();

    if(ozel_deger!=en_son){
        en_son=ozel_deger;
        Serial.println(ozel_deger);
        digitalWrite(buzzer, HIGH);  
        delay(61); 
        digitalWrite(buzzer, LOW);
        delay(61);   
        digitalWrite(buzzer, HIGH);  
        delay(125); 
        digitalWrite(buzzer, LOW);
        delay(125);  
        digitalWrite(buzzer, HIGH);  
        delay(250); 
        digitalWrite(buzzer, LOW);
        delay(250);  
        bant_motor.setSpeed(60);
          if(en_son==87 || en_son==183){
            //step
            kapi_a.write(125);
            kapi_b.write(180);
            bant_motor.step(-500);
            }
           if(en_son==39 || en_son==23){
            kapi_a.write(180);
            kapi_b.write(130);
            bant_motor.step(-700);
            }  
            if(en_son==103 || en_son==231){
            kapi_a.write(180);
            kapi_b.write(180);
            bant_motor.step(-900);
            } 

      }
  }
