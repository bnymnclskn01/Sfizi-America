$('.btnDelete').click(function (e) {
    e.preventDefault()
    const id = $(this).data('id')
    Swal.fire({
        title: 'Are you sure you want to delete?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes!',
        cancelButtonText: 'No'
    }).then((result) => {
        if (result.isConfirmed) {
            deleteRequest(id)
        }
    })
})

function deleteRequest(id) {
    $.ajax({
        url: '/admin/catering-sil/' + id,
        type: 'POST',
        success: (res) => {
            Swal.fire({
                title: 'Successfully Deleted!',
                icon: 'success',
                confirmButtonText: 'Ok'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/catering-listele"
                }
            })
        },
        error: (res) => {
            Swal.fire({
                title: 'An error occurred while deleting!',
                icon: 'error',
                confirmButtonText: 'Ok'
            })
        }
    })
}