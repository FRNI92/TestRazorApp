const wrapper = document.querySelector('.wrapper');
const loginLink = document.querySelector('.login-link');
const registerLink = document.querySelector('.register-link');

const btnPopup = document.querySelector('.btnLogin-popup');

const iconClose = document.querySelector('.icon-close');





registerLink.addEventListener('click', () => {
    wrapper.classList.add('active');
});


loginLink.addEventListener('click', () => {
    wrapper.classList.remove('active');
});

btnPopup.addEventListener('click', () => {
    // Toggla 'active-popup' för att visa/dölja login-rutan
    wrapper.classList.toggle('active-popup');
});//this one makes it so you can click on the login in the meny
//to close the login screen again


iconClose.addEventListener('click', () => {
    wrapper.classList.remove('active-popup');
});
