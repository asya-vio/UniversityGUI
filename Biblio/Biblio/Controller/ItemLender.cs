using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    class ItemLender
    {
        public int IDLender;

        public List<ItemLending> LendedItem;

        public ItemLenderBase DataBase;

        public ItemLender(ItemLenderBase dataBase)
        {
            this.DataBase = dataBase;

            LendedItem = new List<ItemLending>();
        }

        public void LandItem()
        {
            //ItemLending itemLending = new ItemLending();

        }

        public void GetItem(int InventoryNumber, int IDPass)
        {
            for (int i = 0; i < LendedItem.Count; i++)
            {
                if (LendedItem[i].InventoryNumber == InventoryNumber && LendedItem[i].IDPass == IDPass)
                {
                    LendedItem.RemoveAt(i);
                    break;
                }
                else
                {
                    Console.WriteLine("Нет данных об этой выдаче");
                    return;
                }
            }
            Console.WriteLine("Выдача успешно закрыта");
            return;
        }

        public List<Book> ShowLandedItem(int IDPass, bool Type)
        {
            //for (int i = 0; i < LandedItem.Count; i++)
            //{
            //    Console.WriteLine("Инвентарный номер - {1}, Номер чит билета - {0}, Дата выдачи - {2}",
            //        LandedItem[i].IdPass, LandedItem[i].InventoryNumber, LandedItem[i].LandingDate);
            //}

            // ищем все Landing'и с указанным ID и типом

            List<ItemLending> tmp = new List<ItemLending>();

            foreach (ItemLending lng in LendedItem)
            {
                if (lng.IDPass == IDPass && lng.IsStudent == Type)
                {
                    tmp.Add(lng);
                }
            }

            // ищем книги, у которых есть экземляры с инвентарным номером выдачи

            List<Book> rezult = new List<Book>();

            foreach (BookExpertiseArea bea in DataBase.Catalog.ListOfExpertiseArea)
            {
                foreach (Book bk in bea.ListOfBook)
                {
                    foreach (BookExemplar exm in bk.ListOfExemplar)
                    {

                        foreach (ItemLending item in tmp)
                        {
                            if (item.InventoryNumber == exm.InventoryNumber)
                            {
                                rezult.Add(bk);
                            }
                        }

                    }
                }
            }

            return rezult;

        }
    }
}
