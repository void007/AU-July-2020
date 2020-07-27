
class Singleton 
{  
    private static Singleton single_instance = null; 
    public String s; 
    private Singleton() 
    { 
        s = "Hey! How you doing"; 
    } 
	
    public static Singleton getInstance() 
    { 
        if (single_instance == null) 
		{
			synchronized(Singleton.class)
			{
				if(single_instance==null)
				{
            single_instance = new Singleton(); 
            }
		}
		}		
        return single_instance; 
    }
}	


//lazy initiazation
public class doubleCheckLockingSingleton{
	public static void main(String args[]){
		Singleton x = Singleton.getInstance();
		System.out.println(x.s);
		Singleton y = Singleton.getInstance();
		System.out.println(y.s);
	}	
		
	
}