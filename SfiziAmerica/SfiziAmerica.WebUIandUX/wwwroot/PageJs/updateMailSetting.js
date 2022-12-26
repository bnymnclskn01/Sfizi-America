$('#form-submit').submit(function (e) {
    e.preventDefault();
    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();

    fdata.append('ID', $('input[name=ID]').val())
    fdata.append('senderMail', $('input[name=senderMail]').val())
    fdata.append('senderMailPassword', $('input[name=senderMailPassword]').val())
    fdata.append('To', $('input[name=To]').val())
    fdata.append('CC', $('input[name=CC]').val())
    fdata.append('BCC', $('input[name=BCC]').val())
    fdata.append('serverMail', $('input[name=serverMail]').val())
    fdata.append('serverPort', $('input[name=serverPort]').val())
    fdata.append('IsActive', activeValue === 1 ? true : false)

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/mail-gonderim-ayarlari-guncelle/',
        processData: false,
        contentType: false,
        type: 'POST',
        data: fdata,
        success: (response) => {
            Swal.fire({
                title: 'Başarıyla Güncellendi!',
                icon: 'success',
                confirmButtonText: 'Tamam'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/mail-gonderim-ayarlari-listele"
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