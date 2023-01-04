CKEDITOR.replace('Description');
$('#form-submit').submit(function (e) {
    e.preventDefault();
    const ckData1 = CKEDITOR.instances.Description.getData();
    if (ckData1.length < 1) {
        alert('Description cannot be left blank.')
        return
    }
    const activeValue = Number($('select[name=IsActive]').val())
    const rankValue = Number($('input[name=Rank]').val())

    const fdata = new FormData();

    const fileInput1 = $('input[name=ImageUrl]')[0];
    const file1 = fileInput1.files[0];

    fdata.append("ImageUrl", file1);
    fdata.append('Rank', rankValue)
    fdata.append('Title', $('input[name=Title]').val())
    fdata.append('ShortDescription', $('textarea[name=ShortDescription]').val())
    fdata.append('Description', ckData1)
    fdata.append('IsActive', activeValue === 1 ? true : false)
    fdata.append('parentCateringID', $('select[name=parentCateringID]').val())

    //Seo
    $('[name^="seo"]').each(function (x, y) {
        fdata.append($(y).attr("name"), $(y).val());
    });

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/catering-ekle',
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
                    window.location.href = "/admin/catering-listele"
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