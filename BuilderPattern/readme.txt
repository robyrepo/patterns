classe product
classe builder
eventuale classe director 

L'idea è quella di avere una classe builder che wrappa n volte un metodo del product che aggiunge sempre nuove funzionalità a se stesso.
Si può avere una classe director che puo avere dei metodi che racchiudono piu versioni dell'oggetto product.
Con versione intendo che l'oggetto product puo' essere costruito con uno 'stato default' con le caratteristiche di defualt minime che gli permettono di funzionare e poi potrebbe avere varie versioni con piu' caratteristiche. L'esempio che mi sembra pertinente potrebbe essere una macchina di default senza optional e poi la versione con sensori, ariacondizionata automatica, telecamera posteriore etc

In pseudo codice :
 
 classe car (product){
   List<obj> part;
 
 add(obj){}
   parts.add(obj) 
 }
  

 classe builder {
  builder.add(xx) //i vari add che servono per craare macchina di default
  builder.addradio(radio){ car.add(obj)}
  builder.addsensor(sensor)
  builder.addcamera(camera)
 }

 classe director {
  director.createcarstandard{
  builder.add(xx)
 }
 
 director.fulloptional{
  builder.add(xx) //i vari add che servono per craare macchina di default
  builder,addradio(radio)
  builder.addsensor(sensor)
  builder.addcamera(camera)
 }
 }
