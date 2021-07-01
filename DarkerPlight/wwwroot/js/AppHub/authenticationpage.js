var app = new Vue({
    el: '#app',
    data: {
        username: '',
        password: '',
        errorMessage:''
    },
    methods: {
        authenticateUser: function () {
            var self = this;
            if (!self.username) {
                $("#errorMsg").css("visibility","visible");
                self.errorMessage = "Username is required";
                return;
            }
            if (!self.password) {
                $("#errorMsg").css("visibility","visible");
                self.errorMessage = "Password is required";
                return;
            }

            var user = {
                username: self.username,
                password: self.password
            }
            axios({
                method: 'post',
                url: '/api/apphub/authenticate',
                data: user
            })
            .then(function (response) {
                if (response.data) {
                    window.location.href = "/ChatRoom/Chat?username=" + response.data;
                }
            })
            .catch(function (err) {
                console.log(err);
            })
        }
    },
    created() {

    }
}); 
