using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class PhoneBook : Phone
    {
        private List<string[]> PhoneList = new List<string[]>();

        public override void insertPhone(string name, string phone)
        {
            bool existed = false;

            for(int i = 0; i < PhoneList.Count; i++)
            {
                if (PhoneList[i][0] == name)
                {
                    PhoneList[i][1] = phone;
                    Console.WriteLine("Cap nhat so dien thoai cho: " + name);
                    existed = true;
                    break;
                }
            }
            if (!existed)
            {
                PhoneList.Add(new string[] { name, phone });
                Console.WriteLine("Them so dien thoai thanh cong cho: " + name);
            }
        }

        public override void RemovePhone(string name)
        {
            PhoneList.RemoveAll(x => x[0]  == name);
            Console.WriteLine("Da xoa so dien thoai cua: " + name);
        }

        public override void UpdatePhone(string name, string newphone)
        {
            for (int i = 0; i < PhoneList.Count; i++)
            {
                if (PhoneList[i][0] == name)
                {
                    PhoneList[i][1] = newphone;
                    Console.WriteLine("Cap nhat so dien thoai cho: " + name);
                    break;
                }
            }
        }

        public override void SearchPhone(string name)
        {
            bool found = false;
            for (int i = 0; i < PhoneList.Count; i++)
            {
                if (PhoneList[i][0] == name)
                {
                    Console.WriteLine("So dien thoai cua " + name + " la: " + PhoneList[i][1]);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("So dien thoai cua " + name + " khong co trong danh sach");
            }
        }

        public override void Sort()
        {
            PhoneList.Sort((x, y) => x[0].CompareTo(y[0]));
        }
    }
}
