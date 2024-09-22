export interface Todo {

task: string;
completed: boolean;
duration: number;
priority?: 'High' | 'Medium' | 'Low';
}
