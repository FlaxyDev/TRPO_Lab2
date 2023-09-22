using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class BitString
    {
        private StringBuilder stringBuilder;

        public event EventHandler FilledWithZeros;

        public BitString()
        {
            stringBuilder = new StringBuilder();
        }

        // Додавання бітової послідовності до стрічки
        public void AddBits(string bits)
        {
            foreach (char bit in bits)
            {
                if (bit != '0' && bit != '1')
                {
                    throw new ArgumentException("Invalid bit: " + bit);
                }

                stringBuilder.Append(bit);
            }
        }

        // Повертає біт за індексом
        public bool GetBit(int index)
        {
            if (index < 0 || index >= stringBuilder.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            return stringBuilder[index] == '1';
        }

        // Повертає кількість бітів у стрічці
        public int Length()
        {
            return stringBuilder.Length;
        }

        // Повертає рядок, що представляє бітову стрічку
        public override string ToString()
        {
            return stringBuilder.ToString();
        }

        public void CheckString()
        {
            if (stringBuilder.ToString().All(bit => bit == '0'))
            {
                // Виникнення події, стрічка заповннена нулями
                OnFilledWithZeros(EventArgs.Empty);
            }
        }

        // Заміна символу за індексом на вказаний символ
        public void ReplaceChar(int index, char replacement)
        {
            if (index < 0 || index >= stringBuilder.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            stringBuilder[index] = replacement;
        }

        protected virtual void OnFilledWithZeros(EventArgs e)
        {
            FilledWithZeros?.Invoke(this, e);
        }
    }
}
