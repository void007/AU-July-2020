

import java.io.*;
public class countFiles{
  public static void main(String args[]){
    File dir=new File("E:\\7TH sem");
    int fileCount=dir.list().length;
    System.out.println("File Count:"+fileCount);
//	String files[]=dir.list();
  File files[]=dir.listFiles();
  for(File file: files){
	  System.out.println(file.getName());
	   System.out.println("File path: "+file.getAbsolutePath());
	  
  }
  }
}