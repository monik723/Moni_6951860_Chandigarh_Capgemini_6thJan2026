// Register
document.getElementById("registerForm").addEventListener("submit", function(e) {
    e.preventDefault();

    let username = document.getElementById("regUsername").value;
    let email = document.getElementById("regEmail").value;
    let password = document.getElementById("regPassword").value;
    let confirmPassword = document.getElementById("confirmPassword").value;

    if(password.length < 6){
        alert("Password must be at least 6 characters");
        return;
    }

    if(password !== confirmPassword){
        alert("Passwords do not match");
        return;
    }

    let user = { username, email, password };
    localStorage.setItem(email, JSON.stringify(user));

    alert("Registration Successful!");
});

// Login
document.getElementById("loginForm").addEventListener("submit", function(e){
    e.preventDefault();

    let email = document.getElementById("loginEmail").value;
    let password = document.getElementById("loginPassword").value;

    let storedUser = JSON.parse(localStorage.getItem(email));

    if(storedUser && storedUser.password === password){
        alert("Login Successful!");
    } else {
        alert("Invalid Credentials!");
    }
});