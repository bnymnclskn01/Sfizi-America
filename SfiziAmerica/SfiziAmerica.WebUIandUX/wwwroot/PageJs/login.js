$('#form-submit').submit(function (e) {
    e.preventDefault();
    const payload = {
        Email: $('input[name=Email]').val(),
        Password: $('input[name=Password]').val(),
    }
    loginRequest(payload)
})

function loginRequest(payload) {
    const urlParams = new URLSearchParams(window.location.search);
    const returnUrl = urlParams.get('ReturnUrl');

    console.log(returnUrl)
    $.ajax({
        url: '/admin/giris-yap',
        type: 'POST',
        data: payload,
        success: () => {
            window.location.href = '/admin/gosterge-paneli'
        },
        error: (response) => {
            Swal.fire({
                title: 'Error!',
                text: response.responseJSON.errorMessage,
                icon: 'error',
                confirmButtonText: 'Ok'
            })
        }
    })
}