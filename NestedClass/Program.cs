using System;
using System.Collections.Generic;

namespace NestedClass
{
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfig(string item)
        {
            foreach (ItemValue iv in listConfig)
            {
                if(iv.GetItem() == item)
                    return iv.GetValue();
            }
            return "";
        }
        private class ItemValue //Configuration안에 선언된 중첩클래스. private로 선언했기에 Configuration밖에선 보이지않음.
        {
            private string item;
            private string value;

            public void SetValue(Configuration config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++) //중첩클래스는 상위클래스 멤버에 자유롭게 접근가능
                {
                    config.listConfig[i] = this;
                    found = true;
                    break;
                }

                if (found == false)
                    config.listConfig.Add(this);
            }

            public string GetItem()
            {
                return item;
            }
            public string GetValue()
            {
                return value;
            }
         
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655,324 KB");

            Console.WriteLine(config.GetConfig("Version"));
           
            Console.WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V 5.0.1");
            Console.WriteLine(config.GetConfig("Version"));
        }
    }
}

//정상출력값
//V5.0
//655,324KB
//V5.0.1

//현 코드 출력값
//655,324KB
//V5.0.1
