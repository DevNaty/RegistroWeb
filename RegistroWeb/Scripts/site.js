        document.addEventListener("DOMContentLoaded", function () {
            document.getElementById("registroForm").addEventListener("submit", function (e) {
                // Validaciones adicionales aquí
                var email = document.getElementById("mail").value;
                if (!validateEmail(email)) {
                    e.preventDefault();
                    alert("Por favor, ingrese un email válido.");
                }
            });
        });

        function validateEmail(email) {
            var re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
            return re.test(email);
        }




        // Aquí puedes agregar lógica para enviar datos al servidor
   
