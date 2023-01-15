$('#form-submit').submit(function (e) {
    e.preventDefault();
    const ckData = CKEDITOR.instances.Description.getData();
    if (ckData.length < 1) {
        alert('Description cannot be left blank.')
        return
    }
    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();
    const fileInput1 = $('input[name=ImageUrl]')[0];
    const file1 = fileInput1.files[0];

    fdata.append("ImageUrl", file1);
    fdata.append('ID', $('input[name=ID]').val())
    fdata.append('Title', $('input[name=Title]').val())
    fdata.append('ShortDescription', $('textarea[name=ShortDescription]').val())
    fdata.append('Description', ckData)
    fdata.append('IsActive', activeValue === 1 ? true : false)

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/vizyon-guncelle/',
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
                    window.location.href = "/admin/vizyon-listele"
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