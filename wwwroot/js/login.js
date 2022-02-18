
const loginForm = document.getElementById("loginForm");
loginForm?.addEventListener("submit", function (event) {
        event.preventDefault();
        const username = document.getElementById("username");
        const password = document.getElementById("password");

        if (username !== null && password !== null) {
                let input = {
                        username : username.value,
                        password : password.value,
                };

                axios.post('/api/auth/login', input)
                .then(function () {
                    window.location.assign("/");
                })
                .catch(function (error) {
                    console.log(error);
                });
        }
});