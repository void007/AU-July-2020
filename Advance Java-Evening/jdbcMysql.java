//
import java.sql.*;
import java.io.File;
import java.util.List;

import org.dom4j.Document;
import org.dom4j.DocumentException;
import org.dom4j.Element;
import org.dom4j.Node;
import org.dom4j.io.SAXReader;


public class jdbcMysql{
		
	public void createDatabase(){
		 String JDBC_DRIVER = "com.mysql.jdbc.Driver";  

   //  Database credentials
    String USER = "root";
    String PASS = "";
	Connection conn=null;
	Statement stmt=null;
	String DB_URL = "jdbc:mysql://localhost/";
		try{
			//jdbc driver
		 Class.forName("com.mysql.jdbc.Driver");	
			//open connection
			conn=DriverManager.getConnection(DB_URL,USER,PASS);
			
			System.out.println("Creating Database");
			stmt=conn.createStatement();
			
			String sql="CREATE DATABASE STUDENT";
			stmt.executeUpdate(sql);
			System.out.println("Database Created");
		}
		catch(Exception e){
			e.printStackTrace();
		}
		//catch(SQLException 	se){
			//se.printStackTrace();
		//}
		
	}
	static final String JDBC_DRIVER = "com.mysql.jdbc.Driver";  
   static final String DB_URL = "jdbc:mysql://localhost/STUDENT";

   //  Database credentials
   static final String USER = "root";
   static final String PASS = "";
   Connection conn = null;
   Statement stmt = null;
	
	public void createTable(){
		try{
			Class.forName("com.mysql.jdbc.Driver");
			
			conn=DriverManager.getConnection(DB_URL,USER,PASS);
			
			stmt=conn.createStatement();
			
			String query= "CREATE TABLE record" +
			                   "(RollNo int not null, " +
							   "Name VARCHAR(30),"+
							   "Surname VARCHAR(30),"+
							   "Gender VARCHAR(10),"+
							   "Marks int,"+
							   "PRIMARY KEY (RollNo))";
							   
			stmt.executeUpdate(query);
            System.out.println("Table record under database student created");			
							   
		}
		catch(Exception e){
			e.printStackTrace();
		}
		
	}
	
	public void InsertDetails(int RollNo, String Name, String Surname,String Gender, int MARKS){
	      try{
             Class.forName("com.mysql.jdbc.Driver");
			
			conn=DriverManager.getConnection(DB_URL,USER,PASS);
			
			stmt=conn.createStatement();
			System.out.println("In insert part"+ RollNo);
			String query="INSERT INTO record (RollNo,Name,Surname,Gender,Marks)" +
			              "VALUES (RollNo,Name,Surname,Gender,MARKS)";
						  
			stmt.executeUpdate(query);
			System.out.println("Value has been inserted");
             			
 
		  }
        catch(Exception e){
           e.printStackTrace();
		}		
		
		
	}
	
	public void closeConnection(){
			try{
			if(conn!=null)
				conn.close();
			}
			catch(Exception e){
				System.out.println(e.getMessage());
			}
				
	}
	
	public static void main(String args[]){
		jdbcMysql dm=new jdbcMysql();
		//call when to create a new database by changing database name
		dm.createDatabase();
		//when to create a new table
		dm.createTable();
		try{
			//int RollNo=0,Marks=0;
		//String Name=null,Surname=null,Gender=null;
			File inputFile = new File("input.txt");
         SAXReader reader = new SAXReader();
         Document document = reader.read( inputFile );

         List<Node> nodes = document.selectNodes("/class/student" );
         
         for (Node node : nodes) { 
             int  RollNo=Integer.parseInt(node.valueOf("@rollno"));
             String Name= node.selectSingleNode("name/firstname").getText()+" "+node.selectSingleNode("name/middlename").getText()+ " "+
			   node.selectSingleNode("name/lastname").getText();
            //System.out.println(Name);
             String Surname= node.selectSingleNode("name/lastname").getText();
               String Gender=node.selectSingleNode("gender").getText();
              int Marks=Integer.parseInt(node.selectSingleNode("marks").getText());
			   //to insert record
			   dm.InsertDetails(RollNo,Name,Surname,Gender,Marks);
			
		}
		}
		catch(DocumentException d){
			d.printStackTrace();
		}
		dm.closeConnection();
		
	}
	
	
	
}