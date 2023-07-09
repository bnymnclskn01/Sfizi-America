$('#form-submit').submit(function (e) {
    e.preventDefault();
    const fileInput1 = $('input[name=ImageUrl]')[0];
    const file1 = fileInput1.files[0];
    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();

    fdata.append("ImageUrl", file1);
    fdata.append('NameSurname', $('input[name=NameSurname]').val())
    fdata.append('Email', $('input[name=Email]').val())
    fdata.append('Phone', $('input[name=Phone]').val())
    fdata.append('Message', $('textarea[name=Message]').val())
    fdata.append('IsActive', activeValue === 1 ? true : false)

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/musteri-yorumlari-ekle/',
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
                    window.location.href = "/admin/musteri-yorumlari-listele"
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