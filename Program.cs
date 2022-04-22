﻿using System;
//Мануал по делегатам


namespace delegateAndEvent{
    
    class Program{
        static void Main(string[] args){

            // превым делом вам нужно понять, кто будет являться издателем события, а кто подписчиком

            //логику работы издателя с.м. в Guns.cs
            // теперь после ознакомления с логикой работы издателя(publisher) можно читать файл programm дальше
            Guns Glock18 = new Guns(); //publisher
            Glock18.Ammo = 18;

            // на этом моменте, рекомендую сначала ознакомится с логикой прописанной в подписчиках(subscriber)
            // в прочем, для саморазвитя, можно представить что мы не знаем какая логика детально прописана в классах подпичсиках, а знаем лишь, что метод для реакции есть 
            classX Obj_X = new classX(); //subscriber
            classY Obj_Y = new classY(); //subscruber

            // А теперь самое интересно, мы руками подписываем эти ОБЪЕКТЫ, на соответствующее событие
            
//на событие выстрела          // подписали соответсвующюю реакцию объектов (при этом сигнатура реакции определенна в делегате)
            Glock18.GunFired += Obj_X.ReactoinOnFire;
            Glock18.GunFired += Obj_Y.ReactoinOnFire;

            Glock18.fire(); //вызываем метод, в которм воспроизводится событие
            
            // заводи программу 
        }

    }


}