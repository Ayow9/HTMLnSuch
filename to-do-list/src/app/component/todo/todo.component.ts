import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Todo } from '../../models/todo';

@Component({
  selector: 'app-todo',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './todo.component.html',
  styleUrl: './todo.component.css'
})
export class TodoComponent {

//properties
tasks:Todo[] = [
  { task: "Take a Walk", completed: true, duration: 20, priority: 'High'},
  { task: "Clean dishes", completed: false, duration: 15, priority: 'Medium' },
  { task: "Defrag hard drive", completed: false, duration: 90, priority: 'Low'},
  { task: "Doin number crunchin (bills)", completed: true, duration: 47, priority: 'Medium'},
]; //using an index method for searching things helps us find things in an array based on the order.

task: string = '';
completed: boolean = false;
duration: number = 0;
priority: any;

//methods

addTask() : void{
this.tasks.push({task: this.task, completed: this.completed, duration: this.duration, priority: this.priority})
this.task = '';
this.completed = false;
this.duration = 0;
}

isComplete() : boolean{
  return this.completed = false;
}


completeTask(strike: Todo) : void{
strike.completed = true;
}

removeTask(index: number): void {
this.tasks.splice(index, 1);
}
}
