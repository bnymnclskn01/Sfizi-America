$('#form-submit').submit(function (e) {
    e.preventDefault();
    const ckData1 = CKEDITOR.instances.Description.getData();
    if (ckData1.length < 1) {
        alert('Description or Technical description cannot be left blank.')
        return
    }
    const activeValue = Number($('select[name=IsActive]').val())

    const fdata = new FormData();

    const fileInput1 = $('input[name=ImageUrl1]')[0];
    const file1 = fileInput1.files[0];
    const fileInput2 = $('input[name=ImageUrl2]')[0];
    const file2 = fileInput2.files[0];
    const fileInput3 = $('input[name=ImageUrl3]')[0];
    const file3 = fileInput3.files[0];
    const fileInput4 = $('input[name=ImageUrl4]')[0];
    const file4 = fileInput4.files[0];

    fdata.append('ID', $('input[name=ID]').val())
    fdata.append("ImageUrl1", file1);
    fdata.append("ImageUrl2", file2);
    fdata.append("ImageUrl3", file3);
    fdata.append("ImageUrl4", file4);
    fdata.append('Title', $('input[name=Title]').val())
    fdata.append('Price', $('input[name=Price]').val())
    fdata.append('Discount', $('input[name=Discount]').val())
    fdata.append('Type', $('input[name=Type]').val())
    fdata.append('ShortDescription', $('textarea[name=ShortDescription]').val())
    fdata.append('Description', ckData1)
    fdata.append('IsActive', activeValue === 1 ? true : false)
    fdata.append('CateringID', $('select[name=CateringID]').val())

    //Seo
    $('[name^="seo"]').each(function (x, y) {
        fdata.append($(y).attr("name"), $(y).val());
    });

    updateRequest(fdata)
})

function updateRequest(fdata) {
    $.ajax({
        url: '/admin/catering-menu-guncelle',
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
                    window.location.href = "/admin/catering-menu-Listele"
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