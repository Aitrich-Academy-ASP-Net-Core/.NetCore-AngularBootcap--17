function getmessage() {
    let input = document.getElementById("chatinput");
    let chatbox = document.getElementById("chatbox"); // Correct selection

    if (input.value.trim() !== "") {
        // Create user message
        let userMessage = document.createElement("div");
        userMessage.classList.add("chatmessage","user","sb5");
        userMessage.textContent = input.value;
        
        // Append user message
        chatbox.appendChild(userMessage);

        // Simulate bot response after delay
        setTimeout(() => {
            

            // Scroll to the bottom for new messages
            chatbox.scrollTop = chatbox.scrollHeight;
        }, 500);

        // Clear input field
        input.value = "";
    }
}
