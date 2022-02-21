const formUpdatePassword = document.getElementById("formPassword");
formUpdatePassword?.addEventListener("submit", function (event) {
        event.preventDefault();
    const password = document.getElementById("password");
    const newPassword = document.getElementById("newPassword");
    const confirmNewPassword = document.getElementById("confirmNewPPassword");
    

    if (
        password !== null &&
        newPassword !== null &&
        confirmNewPassword !== null    
        ) {
                let input = {
                    password: password.value,
                    newPassword: newPassword.value,
                    confirmNewPassword: confirmNewPassword.value
                    
                };

                axios.post('/api/user/password', input)
                .then(function () {
                    window.location.assign("/auth/login");
                })
                .catch(function (error) {
                    console.log(error);
                });
        }
});