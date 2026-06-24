using System;
using System.Collections.Generic;
using System.Text;

namespace DrawIt
{
    public  class CardObject
    {
       public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int ID { get; set; }
        public string ImagePath { get; set; }
        public bool Revealed { get; set; }
        public bool PowerActive { get; set; }
        public Enum CardType { get; set; }
        public Enum CardDiscardingType { get; set; }
        public object SpecialEffect { get; set; }
    }
   
    }
