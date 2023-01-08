﻿$('.btnDelete').click(function (e) {
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
        url: '/admin/etkinlik-sil/' + id,
        type: 'POST',
        success: (res) => {
            Swal.fire({
                title: 'Successfully Deleted!',
                icon: 'success',
                confirmButtonText: 'Tamam'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/etkinlik-listele"
                }
            })
        },
        error: (res) => {
            Swal.fire({
                title: 'An error occurred while deleting!',
                icon: 'error',
                confirmButtonText: 'Tamam'
            })
        }
    })
}