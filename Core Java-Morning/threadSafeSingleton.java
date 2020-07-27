
class Singleton 
{  
    private static Singleton single_instance = null; 
    public String s; 
    private Singleton() 
    { 
        s = "Hey! How you doing"; 
    } 
	
    synchronized public static Singleton getInstance() 
    { 
        if (single_instance == null) 
            single_instance = new Singleton(); 
  
        return single_instance; 
    } 
}

//lazy initiazation
public class threadSafeSingleton{
	public static void main(String args[]){
		Singleton x = Singleton.getInstance();
		System.out.println(x.s);
		sleep(100);
		Singleton y = Singleton.getInstance();
		System.out.println(y.s);
	}	
		
	
}