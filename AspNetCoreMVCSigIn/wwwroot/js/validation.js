const formErrorHandler = (el, validationResult ) => {
    let spanElement = document.querySelector(`[data-valmsg-for="${el.name}"]`);

    
    if (validationResult) {
        el.classList.remove('input-validation-error');
        spanElement.classList.remove('field-validation-error');
        spanElement.classList.add('field-validation-valid');
        spanElement.innerHTML = '';
    } else {
        el.classList.add('input-validation-error');
        spanElement.classList.add('field-validation-error');
        spanElement.classList.remove('field-validation-valid');
        spanElement.innerHTML = el.dataset.valRequired;

    }
}

const compareValidator = (element, compareWithValue) => {
    if (element === compareWithValue)
        return true;

    return false;
}

const textValidator = (el, minLength = 2) => {
    if (el.value.length >= minLength) {
        formErrorHandler(el, true);
    }
    else {
        formErrorHandler(el, false);
    }


}

const checkboxValidator = (el) => {
    if (el.checked) {
        formErrorHandler(el, true);

    }
    else {
        formErrorHandler(el, false);

    }

}

const emailValidator = (el) => {
    const regex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;

    formErrorHandler(el, regex.test(el.value));
}

const passwordValidator = (el) => {
    if (el.dataset.valEqualtoOther !== undefined) {
        console.log(el.dataset.valEqualtoOther.replace('*', 'Form'))
        formErrorHandler(el, compareValidator(el.value, document.getElementsByName(el.dataset.valEqualtoOther.replace('*', 'Form'))[0].value))
    }
    else {
        const regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;
        formErrorHandler(el, regex.test(el.value))
    }
}

let forms = document.querySelectorAll('form');
let inputs = forms[0].querySelectorAll('input');

inputs.forEach(input => {
    if (input.dataset.val === 'true') {

        if (input.type === 'checkbox') {
            input.addEventListener('change', (e) => {
                checkboxValidator(e.target);
            })
        }
        else {
            input.addEventListener('keyup', (e) => {
                switch (e.target.type) {
                    case 'text':
                        textValidator(e.target)
                        break;
                    case 'email':
                        emailValidator(e.target)
                        break;
                    case 'password':
                        passwordValidator(e.target)
                        break;
                }
            })
        }
    }
})