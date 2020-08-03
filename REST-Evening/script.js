//
const express = require('express');
const Joi = require('@hapi/joi'); //used for validation
const app = express();
app.use(express.json());
 
const todos = [
{title: 'Do assignment', id: 1},
{title: 'Sleep over', id: 2},
{title: 'Movie Nigth', id: 3},
{title:'DL appointment', id: -4 }
]
 
//READ Request Handlers
app.get('/', (req, res) => {
res.send('<h1>Welcome to basic REST implementationon!</h1>');
});
 
app.get('/api/todos', (req,res)=> {
res.send(todos);
});
 
app.get('/api/todos/:id', (req, res) => {
const todo = todos.find(c => c.id === parseInt(req.params.id));
 
if (!todo) res.status(404).send('<h2 style="font-family: Malgun Gothic; color: darkred;">Ooops... Cant find what you are looking for!</h2>');
res.send(todo);
});
 
 
 //CREATE Request Handler
app.post('/api/todos', (req, res)=> {
 
const { error } = validatetodo(req.body);
if (error){
res.status(400).send(error.details[0].message)
return;
}
const todo = {
id: todos.length + 1,
title: req.body.title
};
todos.push(todo);
res.send(todo);
});
 
//UPDATE Request Handler
app.put('/api/todos/:id', (req, res) => {
const todo = todos.find(c=> c.id === parseInt(req.params.id));
if (!todo) res.status(404).send('<h2>Not Found!! </h2>');
 
const { error } = validatetodo(req.body);
if (error){
res.status(400).send(error.details[0].message);
return;
}
 
todo.title = req.body.title;
res.send(todo);
});

//DELETE Request Handler
app.delete('/api/todos/:id', (req, res) => {
 
const todo = todos.find( c=> c.id === parseInt(req.params.id));
if(!todo) res.status(404).send('<h2> Not Found!! </h2>');
 
const index = todos.indexOf(todo);
todos.splice(index,1);
 
res.send(todo);
});
 
function validatetodo(todo) {
const schema = Joi.object({
title: Joi.string().min(3).required()
});
return schema.validate(todo);
 
}
 
//PORT ENVIRONMENT VARIABLE
const port = process.env.PORT || 8080;
app.listen(port, () => console.log(`Listening on port ${port}..`));