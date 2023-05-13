$('#form-submit').submit(function (e) {
    e.preventDefault();
    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();
    const fileInput1 = $('input[name=LogoUrl]')[0];
    const file1 = fileInput1.files[0];

    fdata.append("LogoUrl", file1);
    fdata.append('Title', $('input[name=Title]').val())
    fdata.append('ImageAltTag', $('input[name=ImageAltTag]').val())
    fdata.append('IsActive', activeValue === 1 ? true : false)

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/logo-ekle',
        processData: false,
        contentType: false,
        type: 'POST',
        data: fdata,
        success: (response) => {
            Swal.fire({
                title: 'Added Successfully!',
                icon: 'success',
                confirmButtonText: 'Ok'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/logo-listele"
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