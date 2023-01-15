$('#form-submit').submit(function (e) {
    e.preventDefault();

    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();

    fdata.append('ID', $('input[name=ID]').val())
    fdata.append('Title', $('input[name=Title]').val())
    fdata.append('Url', $('input[name=Url]').val())
    fdata.append('Icon', $('select[name=Icon]').val())
    fdata.append('IsActive', activeValue === 1 ? true : false)

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/sosyal-medya-guncelle',
        processData: false,
        contentType: false,
        type: 'POST',
        data: fdata,
        success: (response) => {
            Swal.fire({
                title: 'Successfully Updated!',
                icon: 'success',
                confirmButtonText: 'Ok'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/sosyal-medya-listele"
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