$('#form-submit').submit(function (e) {
    e.preventDefault();

    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();

    fdata.append('ID', $('input[name=ID]').val())
    fdata.append('NameSurname', $('input[name=NameSurname]').val())
    fdata.append('Phone', $('input[name=Phone]').val())
    fdata.append('Email', $('input[name=Email]').val())
    fdata.append('Person', $('select[name="Person"]').val())
    fdata.append('Date', $('input[name=Date]').val())
    fdata.append('Time', $('select[name=Time]').val())
    fdata.append('Message', $('textarea[name=Message').val())
    fdata.append('TableType', $('select[name=TableType]').val())
    fdata.append('IsActive', activeValue === 1 ? true : false)

    addRequest(fdata)
})

function addRequest(payload) {
    $.ajax({
        url: '/admin/rezervasyon-guncelle',
        processData: false,
        contentType: false,
        type: 'POST',
        data: payload,
        success: (response) => {
            Swal.fire({
                title: 'Successfully Updated!',
                icon: 'success',
                confirmButtonText: 'Ok'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/rezervasyon-listele"
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