import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent implements OnInit {

  form!: FormGroup;

  constructor(public fb: FormBuilder) { }

  get f(): any { return this.form.controls; }

  ngOnInit(): void {
    this.validation();
  }
  private validation(): void {
    this.form = this.fb.group({
      primeiroNome: ['', Validators.required],
      ultimoNome: ['',
        [Validators.required, Validators.email]
      ],
      email: ['', Validators.required],
      userName: ['', Validators.required],
      senha: ['',
        [Validators.required, Validators.minLength(6)]
      ],
      confirmeSenha: ['', Validators.required],
    });
  }
}
