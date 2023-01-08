$('#form-submit').submit(function (e) {
    e.preventDefault();
    const ckData1 = CKEDITOR.instances.Description.getData();
    if (ckData1.length < 1) {
        alert('Description or Technical description cannot be left blank.')
        return
    }
    const activeValue = Number($('select[name=IsActive]').val())

    const fdata = new FormData();

    const fileInput1 = $('input[name=ImageUrl]')[0];
    const file1 = fileInput1.files[0];

    fdata.append('ID', $('input[name=ID]').val())
    fdata.append("ImageUrl", file1);
    fdata.append('Title', $('input[name=Title]').val())
    fdata.append('ShortDescription', $('textarea[name=ShortDescription]').val())
    fdata.append('Description', ckData1)
    fdata.append('IsActive', activeValue === 1 ? true : false)

    //Seo
    $('[name^="seo"]').each(function (x, y) {
        fdata.append($(y).attr("name"), $(y).val());
    });

    updateRequest(fdata)
})

function updateRequest(fdata) {
    $.ajax({
        url: '/admin/etkinlik-guncelle',
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
                    window.location.href = "/admin/etkinlik-listele"
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