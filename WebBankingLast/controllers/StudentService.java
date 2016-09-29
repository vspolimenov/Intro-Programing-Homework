package bg.jwd.university.services;

import java.util.List;

import bg.jwd.university.entities.Student;

public interface StudentService {
	boolean addStudent(Student student);

	List<Student> getStudents();
}