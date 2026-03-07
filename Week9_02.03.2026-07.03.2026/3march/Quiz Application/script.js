let tasks = JSON.parse(localStorage.getItem("tasks")) || [];

function saveTasks(){
    localStorage.setItem("tasks", JSON.stringify(tasks));
}

function renderTasks(){
    let list = document.getElementById("taskList");
    list.innerHTML = "";

    tasks.forEach((task, index) => {
        let li = document.createElement("li");
        li.textContent = task.text;
        if(task.completed){
            li.classList.add("completed");
        }

        li.onclick = () => {
            tasks[index].completed = !tasks[index].completed;
            saveTasks();
            renderTasks();
        };

        let delBtn = document.createElement("button");
        delBtn.textContent = "X";
        delBtn.onclick = (e) => {
            e.stopPropagation();
            tasks.splice(index,1);
            saveTasks();
            renderTasks();
        };

        li.appendChild(delBtn);
        list.appendChild(li);
    });
}

function addTask(){
    let input = document.getElementById("taskInput");
    if(input.value.trim() === "") return;

    tasks.push({ text: input.value, completed: false });
    input.value = "";
    saveTasks();
    renderTasks();
}

renderTasks();