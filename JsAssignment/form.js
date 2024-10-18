document.addEventListener("DOMContentLoaded", () => {
    const form = document.getElementById("auth-form");
    const formTitle = document.getElementById("form-title");
    const toggleLink = document.getElementById("toggle-link");
    const submitButton = form.querySelector("button");
  
    let isSignUp = true;
  
    // Toggle between sign-up and login states
    const toggleFormState = () => {
      isSignUp = !isSignUp;
      formTitle.textContent = isSignUp ? "Sign Up" : "Login";
      submitButton.textContent = isSignUp ? "Sign Up" : "Login";
      toggleLink.textContent = isSignUp
        ? "Already have an account? Login"
        : "Don't have an account? Sign Up";
    };
  
    toggleLink.addEventListener("click", toggleFormState);
  
    form.addEventListener("submit", (event) => {
      event.preventDefault();
  
      const username = document.getElementById("username").value.trim();
      const password = document.getElementById("password").value.trim();
  
      if (!username || !password) {
        alert("Please fill in both fields.");
        return;
      }
  
      if (isSignUp) {
        localStorage.setItem("username", username);
        localStorage.setItem("password", password);
        alert("Sign Up successful! You can now login.");
        toggleFormState(); 
      } else {
        const storedUsername = localStorage.getItem("username");
        const storedPassword = localStorage.getItem("password");
  
        if (username === storedUsername && password === storedPassword) {
          alert("Login successful!");
        } else {
          alert("Invalid username or password.");
        }
      }
    });
  });
  