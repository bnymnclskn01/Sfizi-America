$('#form-submit').submit(function (e) {
    e.preventDefault();

    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();

    fdata.append('ID', $('input[name=ID]').val())
    fdata.append('RoleName', $('input[name=RoleName]').val())
    fdata.append('RoleCode', $('input[name=RoleCode]').val())
    fdata.append('IsActive', activeValue === 1 ? true : false)

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/kullanici-rol-guncelle',
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
                    window.location.href = "/admin/kullanici-rol-listele"
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