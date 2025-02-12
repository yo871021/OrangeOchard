import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SelfpickComponent } from './selfpick.component';

describe('SelfpickComponent', () => {
  let component: SelfpickComponent;
  let fixture: ComponentFixture<SelfpickComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SelfpickComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SelfpickComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
