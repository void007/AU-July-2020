import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  title = 'project2';
  newUser = {first:'',last:'',age:"",empId:'',city:''};
  user1 = {first:'Mandeep',last:'Yadav',age:"22",empId:'INT441',city:'Pratapgarh'};
  user2 = {first:'Nischay',last:'Chauhan',age:"22",empId:'INT442',city:'Faridabad'};
  name = [this.user1,this.user2];
  delkey = null;

  
  ngOnInit(){ 

  }
 
   
  addUser = () =>{
      let userAdd = {first:'',last:'',age:"",empId:'',city:''};
      userAdd.first = this.newUser.first;
      userAdd.last = this.newUser.last;
      userAdd.age = this.newUser.age;
      userAdd.empId = this.newUser.empId;
      userAdd.city = this.newUser.city;
      
      this.name.push(userAdd);
     // newUser = {first:'',last:'',age:"",empId:'',city:''};
      return ;
  } 
  
  sortUser1 = () =>{
     this.name.sort((a,b) => a.first.localeCompare(b.first));
     return ;
  }
  sortUser2 = () =>{
    this.name.sort((a,b) => a.last.localeCompare(b.last));
    return ;
 }
 sortUser3 = () =>{
  this.name.sort((a,b) => a.age.localeCompare(b.age));
  return ;
}
sortUser4 = () =>{
  this.name.sort((a,b) => a.empId.localeCompare(b.empId));
  return ;
}
sortUser5 = () =>{
  this.name.sort((a,b) => a.city.localeCompare(b.city));
  return ;
}

updateUser= () =>{
  let userAdd = {first:'',last:'',age:"",empId:'',city:''};
      userAdd.first = this.newUser.first;
      userAdd.last = this.newUser.last;
      userAdd.age = this.newUser.age;
      userAdd.empId = this.newUser.empId;
      userAdd.city = this.newUser.city;
  var num : Number = null;
  for(var i=0;i<this.name.length;i++){
    var obj = this.name[i];
    if(obj.empId == this.newUser.empId){
      this.name[i] = userAdd;
      break;
    }
  }
  
  
}

deleteUser=()=>{
  
  
  for(var i=0;i<this.name.length;i++){
    var obj = this.name[i];
    if(obj.empId == this.delkey){
      this.name.splice(i,1);
      break;
    }
  }
}

  

}
