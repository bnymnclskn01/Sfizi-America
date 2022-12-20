$('#form-submit').submit(function (e) {
    e.preventDefault();

    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();

    fdata.append('WhatsApp', $('input[name=RoleName]').val())
    fdata.append('Phone', $('input[name=RoleCode]').val())
    fdata.append('IsActive', activeValue === 1 ? true : false)

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/kullanici-rol-ekle',
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
                    window.location.href = "/admin/kullanici-rol-listele"
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