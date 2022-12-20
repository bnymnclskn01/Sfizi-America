$('#form-submit').submit(function (e) {
    e.preventDefault();

    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();

    fdata.append('ID', $('input[name=ID]').val())
    fdata.append('WhatsApp', $('input[name=WhatsApp]').val())
    fdata.append('Phone', $('input[name=Phone]').val())
    fdata.append('Phone2', $('input[name=Phone2]').val())
    fdata.append('Phone3', $('input[name=Phone3]').val())
    fdata.append('Phone4', $('input[name=Phone4]').val())
    fdata.append('Email', $('input[name=Email]').val())
    fdata.append('Email2', $('input[name=Email2]').val())
    fdata.append('Email3', $('input[name=Email3]').val())
    fdata.append('Email4', $('input[name=Email4]').val())
    fdata.append('Address', $('textarea[name=Address').val())
    fdata.append('Address2', $('textarea[name=Address2').val())
    fdata.append('Address3', $('textarea[name=Address3').val())
    fdata.append('Address4', $('textarea[name=Address4').val())
    fdata.append('IsActive', activeValue === 1 ? true : false)

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/iletisim-bilgisi-guncelle',
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
                    window.location.href = "/admin/iletisim-bilgileri-listele"
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