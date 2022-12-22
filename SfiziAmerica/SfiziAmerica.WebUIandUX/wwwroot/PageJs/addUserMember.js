$('#form-submit').submit(function (e) {
    e.preventDefault();
    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();
    fdata.append('NameSurname', $('input[name=NameSurname]').val())
    fdata.append('Email', $('input[name=Email]').val())
    fdata.append('Phone', $('input[name=Phone]').val())
    fdata.append('Password', $('input[name=Password]').val())
    fdata.append('IsActive', activeValue === 1 ? true : false)
    fdata.append('UserRoleID', $('select[name=UserRoleID]').val())

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/kullanici-ekle',
        processData: false,
        contentType: false,
        type: 'POST',
        data: fdata,
        success: (response) => {
            Swal.fire({
                title: 'Başarıyla Eklendi!',
                icon: 'success',
                confirmButtonText: 'Tamam'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/kullanici-listele"
                }
            })
        },
        error: (response) => {
            Swal.fire({
                title: 'Hata!',
                text: response.responseJSON.errorMessage,
                icon: 'error',
                confirmButtonText: 'Tamam'
            })
        }
    })
}