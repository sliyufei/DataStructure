using System;
namespace DataStructureCore.LinearTableSamples.SequenceListSamples
{
    public class SequenceList<T>
    {
        public T[] Datas { get; set; }

        public int Length { get; set; }


        public SequenceList(T[] TArray)
        {
            this.Datas = TArray;
            this.Length = Datas.Length;
        }

        public bool IsEmpty { get { return this.Length <= 0; } }

        public void Print()
        {
            foreach (var data in Datas)
            {
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(data));
            }
        }


        public T GetElement(int index)
        {
            if (index > Datas.Length)
                return default(T);

            return Datas[index];
        }

        public int GetIndex(T t)
        {
            var index = -1;
            for (int i = 0; i < Datas.Length; i++)
            {
                if (Datas[i].Equals(t))
                {
                    index = i;
                    break;
                }
            }
            
            return index;
        }

        public void Insert(T t,int index)
        {
            var tmpArray = new T[Datas.Length + 1];


            //把index之前的原样复制
            for (int i = 0; i < index; i++)
            {
                tmpArray[i] = Datas[i];
            }
            
            tmpArray[index] = t;

            //把index之后的元素往后移位置
            for (int i = index; i < Datas.Length; i++)
            {
                tmpArray[i+1] = Datas[i];
            }

            this.Datas = tmpArray;
            this.Length++;

        }

        public void Delete(int index)
        {
           
            //把index和index之后的元素往前移位置
            for (int i = index; i < Datas.Length-1; i++)
            {
                Datas[i] = Datas[i+1];
            }
            Datas[Length-1] = default(T);
            this.Length--;

        }


    }
}
