var popup = document.querySelector(".users-btn");
var login = popup.querySelector(".login");
var logout = popup.querySelector(".logout");

login.addEventListener("click", function (evt) {
    logout.classList.remove("invisible");
    login.classList.add("invisible");
}, );
logout.addEventListener("click", function (evt) {
    login.classList.remove("invisible");
    logout.classList.add("invisible");
}, );
