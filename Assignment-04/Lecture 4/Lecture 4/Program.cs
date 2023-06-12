//1 სორტირება

Console.WriteLine("Sheiyvanet masivis sigrdze :");
int arraylength = Convert.ToInt32(Console.ReadLine());

int[] myarray = new int[arraylength];
int localvar = 0;

    int[] array = new int[arraylength];
    int i;

    Console.WriteLine("Sheiyvanet elementebi :" );
    for (i = 0; i < arraylength; i++)
    {
        Console.Write("elementi - {0} : ", i);
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

Console.Write("Elementebi masivSi: ");
    for (i = 0; i < arraylength; i++)
    {
        for (int j = i +1; j < arraylength; j++)
         {
        if (array[i] > array[j])
        {
            localvar = array[j];
            array[j] = array[i];
            array[i] = localvar;
        }
    }
        
        Console.Write("{0}  ", array[i]);
    }
  

