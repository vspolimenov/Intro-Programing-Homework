package bg.jwd.university.services;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Service;

import bg.jwd.university.entities.Student;

@Service
public class StudentServiceImpl implements StudentService {

	private static List<Student> students = new ArrayList<>();

	@Override
	public boolean addStudent(Student student) {
		students.add(student);

		return true;
	}

	@Override
	public List<Student> getStudents() {
		return students;
	}
}