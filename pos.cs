class bucket
{
   private int []a;
   private int i,j;

   public void sum(int x)
   {
     a=new int[x];
   }
    public void sum()
   {
     a=new int[10];
   }
    public void add(int y)
   {
     a[i]=y;
     i++;
   }
   public int find (int z)
   {
     for(j=0;j<i;j++)
      {
        if(a[j]==z)
          {
            return j;
          }
       }
              return -1;
     }
   public void show(int p)
   {
    System.Console.WriteLine(p);
   }
 }

 class program
{
   public static void Main()
    {
     int pos;
     bucket b;
     b=new bucket();
     b.sum(100); 
     b.add(200); 
     b.add(300); 
     b.add(400); 
     b.add(500);
   pos=  b.find(700);
   //System.Console.WriteLine("{0}",pos);
     b.show(pos);
    }
}  