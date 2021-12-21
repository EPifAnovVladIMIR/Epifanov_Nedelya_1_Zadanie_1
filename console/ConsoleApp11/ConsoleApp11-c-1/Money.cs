using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11_c_1
{
    class Money
    {
        // поля
        private int m_denomination { get; set; }          // first
        private int m_numberOfBills { get; set; }         // second

        // свойства
        public int Denomination
        {
            get
            {
                return m_denomination;
            }
            set
            {
                m_denomination = value;
            }
        }
        public int NumberOfBills
        {
            get
            {
                return m_numberOfBills;
            }
            set
            {
                m_numberOfBills = value;
            }
        }
        public int MoneySumm
        {
            get
            {
                return m_denomination * m_numberOfBills;
            }
        }
        // конструктор
        public Money(int denomination,int numberOfBills)
        {
            m_denomination = denomination;
            m_numberOfBills = numberOfBills;
        }

        // вывести номинал и количество купюр (здесь перегрузка метод родительского класса Object, для преобразования типа в строку)
        public override string ToString()
        {
            return $"Denomination: {m_denomination}, number of bills: {m_numberOfBills}";
        }

        // определить хватит ли денежных средств...
        public bool IsEnought(int rubles)
        {
            if (m_denomination * m_numberOfBills >= rubles)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // определить хватит ли денежных средств...
        public int GetNumberOfProducts(int price)
        {
            return m_denomination * m_numberOfBills / price;
        }

    }
}
