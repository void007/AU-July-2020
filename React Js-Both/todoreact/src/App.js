import React from 'react';
import './App.css';
import ListTodo from './ListTodo'
import { library } from '@fortawesome/fontawesome-svg-core'
import { faTrash } from '@fortawesome/free-solid-svg-icons'

library.add(faTrash)

class App extends React.Component {
  constructor(props){
    super(props);
    this.state = {
      items:[],
      currentItem:{
        text:'',
        key:''
      }
    }
    this.addItem = this.addItem.bind(this);
    this.handleInput = this.handleInput.bind(this);
    this.deleteItem=this.deleteItem.bind(this);
    this.setUpdate=this.setUpdate.bind(this);
     this.clearTodo=this.clearTodo.bind(this);
  }
  addItem(e){
    e.preventDefault();
    const newItem = this.state.currentItem;
    if(newItem.text !==""){
      const items = [...this.state.items, newItem];
    this.setState({
      items: items,
      currentItem:{
        text:'',
        key:''
      }
    })
    }
  }

  handleInput(e){
    this.setState({
      currentItem:{
        text: e.target.value,
        key: Date.now()
      }
    })
  }

  deleteItem(key){
    const filteredItems= this.state.items.filter(item =>
      item.key!==key);
    this.setState({
      items: filteredItems
    })

  }
  setUpdate(text,key){
    console.log("items:"+this.state.items);
    const items = this.state.items;
    items.map(item=>{      
      if(item.key===key){
        console.log(item.key +"    "+key)
        item.text= text;
      }
    })
    this.setState({
      items: items
    })
    
   
  }

  clearTodo(){
      this.setState({
        items:[],
        currentItem:{
          text:'',
          key:''
        }
      })


  }


  render(){
  return (
    <div className="App">
      
      <header>Todo Input</header>
       <input id="input" type="text" placeholder="Enter your todo here.." 
        value= {this.state.currentItem.text} onChange={this.handleInput}></input>
       <button id="submit" type="button" onClick={this.addItem}>Add todo</button>

       <ListTodo items={this.state.items} deleteItem={this.deleteItem} setUpdate={this.setUpdate}/>

       <button id="clear" type="button" onClick={this.clearTodo}>Clear Todo</button>
    </div>
  );
}

}
export default App;
