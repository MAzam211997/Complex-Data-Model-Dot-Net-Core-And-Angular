import { TestBed } from '@angular/core/testing';

import { OfficeAssignmentsService } from './office-assignments.service';

describe('OfficeAssignmentsService', () => {
  let service: OfficeAssignmentsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OfficeAssignmentsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
