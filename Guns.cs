using System;

namespace delegateAndEvent{

    class Guns{

        //Первым делом определим делегат, сигнатуру делегата будем назвать контрактом взаимодействия издателя и подписчика 
        public delegate void GunFiredEventHandler(); //обратите внимание, классический стандарт с# препдолагает приставку EventHandler к делегату, т.к. именно делегат определяет логику взаимодействие => является обработчиком события

        //Шаг два, пропишем событые
        public event GunFiredEventHandler ?GunFired; //прошедшее время выбрано не случайно, если использовать русский синтаксис, все становится ясно(Публичное событие Пистолет_выстрелил)

        //шаг три, пропишем активатор
        protected virtual void OnGunFired(){ //так же обрати внимание на синтаксис, ON(КОГДА) = когда пистолет выстрелил 
            if(GunFired != null){
                GunFired();
            }
            // не исключенно добавление дополнительно логики, которую подразумеват разработчик
        }

        private double ammo;
        public double Ammo{
            get{return ammo;}
            set{ammo = value;}
        }
        public void fire(){
            if (this.ammo > 0) {
                this.ammo--;
                System.Console.WriteLine("BANG!!");
                OnGunFired(); // Тут я и вызываю данное событие, т.к. именно в этом моменте пистолет сделал выстрел
            }
        } 

    }

}