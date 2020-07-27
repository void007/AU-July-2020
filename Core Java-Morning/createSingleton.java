//Sangeetha - live:ssangita2716
//Manasa  - Manasa Raju K K

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
            single_instance = new Singleton(); 
  
        return single_instance; 
    } 
}

//lazy initiazation
public class createSingleton{
	public static void main(String args[]){
		Singleton x = Singleton.getInstance();
		System.out.println(x.s);
		
		Singleton y = Singleton.getInstance();
		y.s=(y.s).toUpperCase();
		System.out.println(y.s);
	   System.out.println(x.s);

		
	}	
		
	
}