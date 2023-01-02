$('#form-submit').submit(function (e) {
    e.preventDefault();
    const activeValue = Number($('select[name=IsActive]').val())
    const payload = {
        ID: $('input[name=ID]').val(),
        NameSurname: $('input[name=NameSurname]').val(),
        Email: $('input[name=Email]').val(),
        Password: $('input[name=Password]').val(),
        Phone: $('input[name=Phone]').val(),
        IsActive: activeValue === 1 ? true : false,
        UserRoleID: $('select[name=UserRoleID]').val()
    }
    updateRequest(payload)
})

function updateRequest(payload) {
    $.ajax({
        url: '/admin/kullanici-guncelle',
        type: 'POST',
        data: payload,
        success: () => {
            Swal.fire({
                title: 'Successfully Updated!',
                icon: 'success',
                confirmButtonText: 'Ok'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/kullanici-listele"
                }
            })
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