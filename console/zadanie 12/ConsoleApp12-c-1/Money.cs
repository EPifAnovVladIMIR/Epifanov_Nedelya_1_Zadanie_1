using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12_c_1
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

        // индексатор
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return m_denomination;
                    case 1: return m_numberOfBills;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: m_denomination = value;break;
                    case 1: m_numberOfBills=value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        // конструктор
        public Money(int denomination,int numberOfBills)
        {
            m_denomination = denomination;
            m_numberOfBills = numberOfBills;
        }

        // перегрузки опреаций
        public static Money operator ++(Money money)
        {
            money.Denomination++;
            money.NumberOfBills++;
            return money;
        }
        public static Money operator --(Money money)
        {
            money.Denomination--;
            money.NumberOfBills--;
            return money;
        }
        public static bool operator !(Money money)
        {
            if (money.NumberOfBills != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Money operator +(Money money,int scalar)
        {
            money.NumberOfBills += scalar;
            return money;
        }
        // преобразование типа в string и наоборот
        public static explicit operator string(Money money)
        {
            return $"{money.Denomination} {money.NumberOfBills}";
        }
        public static explicit operator Money(string str)
        {
            string[] args = str.Split(' ');
            return new Money(int.Parse(args[0]),int.Parse(args[1]));
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
